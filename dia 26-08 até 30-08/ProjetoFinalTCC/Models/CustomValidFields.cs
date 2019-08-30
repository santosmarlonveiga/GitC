using ProjetoFinalTCC.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace ProjetoFinalTCC.Models
{
    public class CustomValidFields : ValidationAttribute
    {
        ContexDb db = new ContexDb();

        private ValidFields typeFields;

        public CustomValidFields(ValidFields type)
        {
            typeFields = type;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                switch (typeFields)
                {
                    case ValidFields.ValidaPlacaCarro: { return ValidarPlaca(value, validationContext); };

                    default: { } break;
                }
            }
            return new ValidationResult($"O campo {validationContext.DisplayName} é obrigatório.");
        }
        private ValidationResult ValidarPlaca(object value, ValidationContext context)
        {
            var placaBrasil = Regex.IsMatch(value.ToString(), @"^[a-zA-Z]{3}[-][0-9]{4}$");
            var placaMercoSul = Regex.IsMatch(value.ToString(), @"^[a-zA-Z]{3}[0-9]{1}[a-zA-Z]{1}[0-9]{2}$");
            var placaMotoMercoSul = Regex.IsMatch(value.ToString(), @"^[a-zA-Z]{3}[0-9]{2}[a-zA-Z]{1}[0-9]{1}$");
            var locacao = context.ObjectInstance as Locacao;
            var verificaPlaca = db.Locacaos.FirstOrDefault(x => x.PlacaCarro == locacao.PlacaCarro);
            var carro = db.TiposDeTransportes.FirstOrDefault(x => x.Descricao == "Automovel").Codigo;
            var moto = db.TiposDeTransportes.FirstOrDefault(x => x.Descricao == "Moto").Codigo;

            if (locacao.CodTipoDeVeiculo == carro || locacao.CodTipoDeVeiculo == moto)
            {
                if (verificaPlaca == null)
                {
                    if (placaBrasil || placaMercoSul || placaMotoMercoSul)
                        return ValidationResult.Success;

                    return new ValidationResult($"O campo {context.DisplayName} é inválido");
                }
                return new ValidationResult("Placa informada já existe");
            }
            return ValidationResult.Success;
        }

    }
}