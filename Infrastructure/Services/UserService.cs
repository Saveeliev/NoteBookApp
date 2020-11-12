using DataBase;
using Dto.User;
using DTO;
using DTO.Responses;
using Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class UserService : BaseService, IUserService
    {
        private readonly IDataProvider _provider;

        public UserService(IDataProvider provider)
        {
            _provider = provider ?? throw new ArgumentNullException(nameof(provider));
        }

        public async Task<ActionResult> Login(LoginRequest request)
        {
            if (request == null)
                return new Error("Request cannot be null");

            var results = new List<ValidationResult>();
            var context = new ValidationContext(request);

            if (!Validator.TryValidateObject(request, context, results, true))
            {
                foreach (var error in results)
                {
                    return new Error(error.ErrorMessage);
                }
            }

            var user = await _provider.Get<UserDb>(i => i.Login == request.Login).SingleOrDefaultAsync();

            if (user == null)
                return new Error("User is not exist");

            if (request.Password != user.Password)
                return new Error("Incorrected password");

            await SetActiveUser(request);

            return new Success();
        }

        public async Task<ActionResult> Register(RegisterRequest request)
        {
            if (request == null)
                return new Error("Request cannot be null");

            var results = new List<ValidationResult>();
            var context = new ValidationContext(request);

            if (!Validator.TryValidateObject(request, context, results, true))
            {
                foreach (var error in results)
                {
                    return new Error(error.ErrorMessage);
                }
            }

            var userDb = await _provider.Get<UserDb>(i => i.Login == request.Login).SingleOrDefaultAsync();

            if (userDb != null)
                return new Error("User is already exist");

            var user = new UserDb { Login = request.Login.ToLower(), Name = request.Name, Password = request.Password };

            await _provider.Insert(user);

            return new Success();
        }

        public async Task<ActionResult> SetActiveUser(LoginRequest request)
        {
            var user = await _provider.Get<UserDb>(i => i.Login == request.Login).SingleOrDefaultAsync();
            var activeUser = new ActiveUser { Login = user.Login, Id = user.Id };
            var path = @"..\..\..\activeUser.json";

            using (var fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                var json = JsonSerializer.Serialize(activeUser);
                var array = System.Text.Encoding.Default.GetBytes(json);
                fs.Write(array, 0, array.Length);
            }

            ActiveUser = activeUser;

            return new Success();
        }

        public ActiveUser GetAndSetActiveUserIfExist()
        {
            var user = GetActiveUserFromJson();

            ActiveUser = user;
            return ActiveUser;
        }

        private ActiveUser GetActiveUserFromJson()
        {
            var path = @"..\..\..\activeUser.json";

            using var fs = File.OpenRead(path);
            var bytes = new byte[fs.Length];
            fs.Read(bytes, 0, bytes.Length);

            if (fs.Length == 0)
                return null;

            return JsonSerializer.Deserialize<ActiveUser>(bytes);
        }

        public void DeleteActiveUser()
        {
            var path = @"..\..\..\activeUser.json";

            using var fs = new FileStream(path, FileMode.Open);
            fs.SetLength(0);

            ActiveUser = null;
        }
    }
}