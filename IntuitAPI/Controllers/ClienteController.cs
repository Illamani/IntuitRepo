using Intuit.Application.Service;
using Intuit.Models;
using Microsoft.AspNetCore.Mvc;

namespace IntuitAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ClienteController(IClienteService clienteService) : ControllerBase
{
    [HttpGet]
    [Route("GetCliente")]
    public async Task<Cliente> GetClienteAsync(int id, CancellationToken cancellationToken)
    {
        return await clienteService.GetAsync(id, cancellationToken);
    }

    [HttpDelete]
    [Route("DeleteCliente")]
    public void DeleteCliente(Cliente cliente)
    {
        clienteService.Delete(cliente);
    }

    [HttpGet]
    [Route("GetAllClientes")]
    public async Task<List<Cliente>> GetAll(CancellationToken cancellationToken)
    {
        return await clienteService.GetAllAsync(cancellationToken);
    }

    [HttpPut]
    [Route("UpdateCliente")]
    public async Task Update(Cliente cliente, CancellationToken cancellationToken)
    {
        await clienteService.UpdateAsync(cliente, cancellationToken);
    }

    [HttpPost]
    [Route("CreateCliente")]
    public async Task Create(Cliente cliente, CancellationToken cancellationToken)
    {
        await clienteService.CreateAsync(cliente, cancellationToken);
    }

}
