namespace WpfAppNew.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Genero")]
    public partial class Genero
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Genero()
        {
            Livros = new HashSet<Livro>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Tipo { get; set; }

        [StringLength(1000)]
        public string Descrição { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Livro> Livros { get; set; }
    }
}
