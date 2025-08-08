using Intuit.Models.Common;

namespace Intuit.Models;

public class Cliente : BaseEntity
{
	public string Nombre { get; set; }

	public string Apellido { get; set; }

	public DateTime FechaNacimiento { get; set; }

	public string CUIT {  get; set; }

	public string Domicilio { get; set; }

	public string NumeroTelefonico { get; set; }

	public string Email { get; set; }
}
