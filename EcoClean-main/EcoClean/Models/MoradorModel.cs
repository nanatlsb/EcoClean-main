﻿namespace EcoClean.Models
{
    public class MoradorModel
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public long EnderecoId { get; set; }
        public EnderecoModel Endereco { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
