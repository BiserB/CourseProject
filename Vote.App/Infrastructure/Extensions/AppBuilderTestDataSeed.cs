using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Vote.Common;
using Vote.Data;
using Vote.Entities;
using Vote.Entities.Dtos;

namespace Vote.App.Infrastructure.Extensions
{
    public static class AppBuilderTestDataSeed
    {
        public static async void TestDataSeed(this IApplicationBuilder app)
        {
            using (var scope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var db = scope.ServiceProvider.GetService<VoteDbContext>();
                var mapper = scope.ServiceProvider.GetService<IMapper>();
                var userManager = scope.ServiceProvider.GetService<UserManager<User>>();

                if (db.Users.Any(u => u.UserName == "pesho"))
                {
                    return;
                }

                string execPath = Assembly.GetExecutingAssembly().Location;

                string basePath = Path.GetFullPath(Path.Combine(Path.GetDirectoryName(execPath), VoteConstants.PathCorrection));

                await SeedUsers(db, userManager);

                await SeedEvents(db, mapper, userManager, basePath);

                SeedQuestions(db, mapper, basePath);

                SeedReplies(db, mapper, basePath);
            }
        }

        private static async Task SeedUsers(VoteDbContext db, UserManager<User> userManager)
        {
            var user = new User() { UserName = "pesho", Email = "pesho@mail.bg", EmailConfirmed = true };
            var user2 = new User() { UserName = "gosho", Email = "gosho@mail.bg", EmailConfirmed = true };

            await userManager.CreateAsync(user, "pass");
            await userManager.CreateAsync(user2, "pass");

            await userManager.AddToRoleAsync(user, RoleType.Manager);
            await userManager.AddToRoleAsync(user2, RoleType.Manager);
        }

        private static async Task SeedEvents(VoteDbContext db, IMapper mapper, UserManager<User> userManager, string basePath)
        {
            string fullPath = Path.Combine(basePath, VoteConstants.JsonEvents);

            var jsonEvents = File.ReadAllText(fullPath);

            var eventDtos = JsonConvert.DeserializeObject<EventDto[]>(jsonEvents);

            var user1Id = (await userManager.FindByNameAsync("pesho")).Id;
            var user2Id = (await userManager.FindByNameAsync("gosho")).Id;

            for (int i = 0; i < eventDtos.Length / 2; i++)
            {
                eventDtos[i].CreatorId = user1Id;
            }

            for (int i = eventDtos.Length / 2; i < eventDtos.Length; i++)
            {
                eventDtos[i].CreatorId = user2Id;
            }

            var eventsData = mapper.Map<List<Event>>(eventDtos);

            db.Events.AddRange(eventsData);

            db.SaveChanges();
        }

        private static void SeedQuestions(VoteDbContext db, IMapper mapper, string basePath)
        {
            string fullPath = Path.Combine(basePath, VoteConstants.JsonQuestions);

            var jsonQuestions = File.ReadAllText(fullPath);

            var questionDtos = JsonConvert.DeserializeObject<QuestionDto[]>(jsonQuestions);

            var questionsData = mapper.Map<List<Question>>(questionDtos);

            db.Questions.AddRange(questionsData);

            db.SaveChanges();
        }

        private static void SeedReplies(VoteDbContext db, IMapper mapper, string basePath)
        {
            string fullPath = Path.Combine(basePath, VoteConstants.JsonReplies);

            var jsonReplies = File.ReadAllText(fullPath);

            var repliesDtos = JsonConvert.DeserializeObject<ReplyDto[]>(jsonReplies);

            var repliesData = mapper.Map<List<Reply>>(repliesDtos);

            db.Replies.AddRange(repliesData);

            db.SaveChanges();
        }
    }
}