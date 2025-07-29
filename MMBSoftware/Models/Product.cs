using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MMBSoftware.Models
{
    public class Product
    {

        //Fields
        private int _id;
        private string _name;
        private string _description;
        private decimal _price;
        private string _category;


        //Properties
        [DisplayName("ID")]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        [DisplayName("Nome")]
        [Required(ErrorMessage = "O nome do produto é necessário!")]
        [StringLength(100, ErrorMessage = "O nome do produto não pode exceder 100 caracteres")]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        [DisplayName("Descrição")]
        [StringLength(500, ErrorMessage = "Descrição do produto não pode exceder 500 caracteres")]
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        [DisplayName("Preço")]
        [Required(ErrorMessage = "O preço do produto é necessário")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be a positive value.")]
        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }

        [DisplayName("Categoria")]
        [Required(ErrorMessage = "A categoria do produto é necessário!")]
        [StringLength(50, ErrorMessage = "Category cannot exceed 50 characters.")]
        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }
    }
}
