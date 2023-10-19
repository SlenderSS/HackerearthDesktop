using HackerearthDesktop.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HackerearthDesktop.Services
{
    internal class LeetcodeProblemsService : Interfaces.ILeetcodeProblemsService
    {
        private readonly HttpClient httpClient;


        
        public Problem GetProblemDescription(Problem problem)
        {
            throw new NotImplementedException();
        }

        public ICollection<Problem> GetProblems()
        {
            HttpResponseMessage response = httpClient.GetAsync("https://leetcode.com/api/problems/all/").Result;

            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new Exception("Не вдалося отримати список задач");
            }

            string responseBody = response.Content.ReadAsStringAsync().Result;

            dynamic parserObject = JObject.Parse(responseBody);
            ICollection<Problem> problems = new List<Problem>();
            foreach (var item in parserObject.stat_status_pairs)
            {
                problems.Add(new Problem
                {
                    Id = item.stat.question_id,
                    Title = item.stat.question__title,
                    TitleSlug = item.stat.question__title_slug
                }); ;
            }
            return problems;
        }

        public LeetcodeProblemsService()
        {
            httpClient = new HttpClient();
        }
    }
}
