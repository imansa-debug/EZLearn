using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EzLearn.DataLayer.Entities.Wallet
{
    public class WalletType
    {
        public WalletType()
        {

        }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TypeId { get; set; }
        [Required]
        [MaxLength(150)]
        public string TypeTitle { get; set; }

        public List<Wallet> Wallets { get; set; }
    }
}
