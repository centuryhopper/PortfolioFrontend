using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using Newtonsoft.Json;
using Business.Entities;
using System.Net.Http.Json;
using Business.DTOs;

namespace PortfolioFrontend.Services;

public class ContactsService : IContactsService<ContactMeModel>
{
    private readonly HttpClient client;

    public ContactsService(IHttpClientFactory httpClientFactory)
    {
        this.client = httpClientFactory.CreateClient("ServerAPI");
    }

    public async Task<ServiceResponse> PostDataAsync(ContactMeModel model)
    {
        System.Console.WriteLine($"creating contact user: {model}");
        var response = await client.PostAsJsonAsync("/api/Contacts/post-contact", model);

        if (response.IsSuccessStatusCode)
        {
            // Console.WriteLine("successfully inserted contact into db");
            var result = await response.Content.ReadFromJsonAsync<ServiceResponse>();
            return result;
        }

        return new ServiceResponse(false, "error posting user message from browser");
    }
}


