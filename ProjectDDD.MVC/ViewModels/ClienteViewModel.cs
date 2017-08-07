using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjectDDD.MVC.ViewModels
{
    public class ClienteViewModel
    {
        [Key]
        public int ClienteId { get; set; }
        [Required(ErrorMessage ="Preencha o nome")]
        [MaxLength(150, ErrorMessage = "Maximo de {0} caracteres")]
        [MinLength(2,ErrorMessage ="Minimo de {0} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o Sobrenome")]
        [MaxLength(150, ErrorMessage = "Maximo de {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo de {0} caracteres")]
        public string Sobrenome { get; set; }
        [Required(ErrorMessage = "Preencha o email")]
        [MaxLength(100, ErrorMessage = "Maximo de {0} caracteres")]
        [EmailAddress(ErrorMessage ="Email invalido")]
        [DisplayName("E-mail")]
        public string Email { get; set; }
        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

        public virtual IEnumerable<ProdutoViewModel> Produtos { get; set; }

    }
}