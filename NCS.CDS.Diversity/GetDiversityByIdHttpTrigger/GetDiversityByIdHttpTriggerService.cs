using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NCS.CDS.Diversity.GetDiversityByIdHttpTrigger
{
    public class GetDiversityByIdHttpTriggerService
    {

        public async Task<Models.Diversity> GetDiversity(Guid diversityId)
        {
            var diversities = CreateTempDiversities();
            var result = diversities.FirstOrDefault(a => a.DiversityId == diversityId);
            return await Task.FromResult(result);
        }

        public List<Models.Diversity> CreateTempDiversities()
        {
            var diversityList = new List<Models.Diversity>
            {
                new Models.Diversity
                {
                    DiversityId = Guid.Parse("b11676c9-e17f-4658-b35e-3fdc23b4adb3"),
                    CustomerId = Guid.NewGuid(),
                    LLDDHealthProblemDeclarationId = 1,
                    PrimaryLLDDHeathProblemId = 2,
                    SecondaryLLDDHeathProblemId = 3,
                    EthnicityId = Guid.NewGuid(),
                    GenderId = Guid.NewGuid(),
                    DateCollected = DateTime.UtcNow,
                    LastModifiedDate = DateTime.UtcNow,
                    LastModifiedBy = Guid.Empty
                },
                new Models.Diversity
                {
                    DiversityId = Guid.Parse("2f9e4ece-95d9-444b-8833-b433f5fd2190"),
                    CustomerId = Guid.NewGuid(),
                    LLDDHealthProblemDeclarationId = 1,
                    PrimaryLLDDHeathProblemId = 2,
                    SecondaryLLDDHeathProblemId = 3,
                    EthnicityId = Guid.NewGuid(),
                    GenderId = Guid.NewGuid(),
                    DateCollected = DateTime.UtcNow,
                    LastModifiedDate = DateTime.UtcNow,
                    LastModifiedBy = Guid.Empty
                },
                new Models.Diversity
                {
                    DiversityId = Guid.Parse("67fefdd2-6e1c-48b8-b9be-2adc5d0d48c4"),
                    CustomerId = Guid.NewGuid(),
                    LLDDHealthProblemDeclarationId = 1,
                    PrimaryLLDDHeathProblemId = 2,
                    SecondaryLLDDHeathProblemId = 3,
                    EthnicityId = Guid.NewGuid(),
                    GenderId = Guid.NewGuid(),
                    DateCollected = DateTime.UtcNow,
                    LastModifiedDate = DateTime.UtcNow,
                    LastModifiedBy = Guid.Empty
                }
            };

            return diversityList;
        }

    }
}