using GlobalSolutionAdmin.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalSolutionAdmin.ViewModels
{
    public class SampleViewModel
    {
        public IEnumerable<ClientDto> SampleClients { get; }

        public SampleViewModel()
        {
            // Generate sample client data
            SampleClients = new List<ClientDto>
            {
                new ClientDto
                {
                    Name = "John Doe",
                    Phone = "1234567890",
                    Email = "john.doe@example.com",
                    Occupation = "Software Engineer",
                    Company = "Acme Corporation",
                    ProfitGenerated = 5000.00m
                },
                new ClientDto
                {
                    Name = "Jane Smith",
                    Phone = "9876543210",
                    Email = "jane.smith@example.com",
                    Occupation = "Marketing Manager",
                    Company = "XYZ Corporation",
                    ProfitGenerated = 7000.00m
                },
                // Add more sample clients as needed
            };
        }
    }
}
