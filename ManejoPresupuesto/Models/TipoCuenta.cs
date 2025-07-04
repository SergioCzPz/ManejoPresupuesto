﻿using System.ComponentModel.DataAnnotations;
using ManejoPresupuesto.Validaciones;
using Microsoft.AspNetCore.Mvc;

namespace ManejoPresupuesto.Models;
//: IValidatableObject
public class TipoCuenta
{
    public int Id { get; set; }
    [Required(ErrorMessage = "El campo {0} es requerido")]
    [PrimeraLetraMayuscula]
    [Remote(action: "VerificarExisteTipoCuenta", controller: "TiposCuentas")]
    public string Nombre { get; set; }
    public int UsuarioId { get; set; }
    public int Orden { get; set; }

    //public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    //{
    //    if (Nombre != null && Nombre.Length > 0)
    //    {
    //        var primeraLetra = Nombre[0].ToString();
    //        if (primeraLetra != primeraLetra.ToUpper())
    //        {
    //            yield return new ValidationResult("La primera letra debe ser mayuscula", new[] { nameof(Nombre) });
    //        }
    //    }
    //}
}