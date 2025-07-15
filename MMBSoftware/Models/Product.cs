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
        [DisplayName("Product ID")]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        [DisplayName("Product Name")]
        [Required(ErrorMessage = "Product name is required.")]
        [StringLength(100, ErrorMessage = "Product name cannot exceed 100 characters.")]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        [DisplayName("Product Description")]
        [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters.")]
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        [DisplayName("Product Price")]
        [Required(ErrorMessage = "Product price is required.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be a positive value.")]
        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }

        [DisplayName("Product Category")]
        [Required(ErrorMessage = "Product category is required.")]
        [StringLength(50, ErrorMessage = "Category cannot exceed 50 characters.")]
        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }
    }
}
