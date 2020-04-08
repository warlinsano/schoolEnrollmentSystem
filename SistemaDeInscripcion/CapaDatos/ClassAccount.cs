using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Windows.Input;

//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;

namespace SistemaDeInscripcion.CapaDatos
{
    class ClassAccount
    {

    }


    public partial class AspNetUserRoles
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("AspNetUser")]
        [StringLength(450)]
        public string UserId { get; set; }

        [ForeignKey("AspNetRole")]
        [StringLength(450)]
        public string RoleId { get; set; }

        public virtual AspNetUser AspNetUser { get; set; }
        public virtual AspNetRole AspNetRole { get; set; }

        //public virtual ICollection<AspNetUser> AspNetUser { get; set; }

        //public virtual ICollection<AspNetRole> AspNetRole { get; set; }
    }

    public partial class AspNetUser
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AspNetUser()
        {
            AspNetUserClaims = new HashSet<AspNetUserClaim>();
            AspNetUserLogins = new HashSet<AspNetUserLogin>();
            AspNetUserTokens = new HashSet<AspNetUserToken>();
            //AspNetRoles = new HashSet<AspNetRole>();

            //AspNetUserRole = new HashSet<AspNetUserRole>();

        }

        [Key]
        [StringLength(450)]
        public string Id { get; set; }

        [StringLength(256)]
        public string UserName { get; set; }

        [StringLength(256)]
        public string NormalizedUserName { get; set; }

        [StringLength(256)]
        public string Email { get; set; }

        [StringLength(256)]
        public string NormalizedEmail { get; set; }

        public bool EmailConfirmed { get; set; }

        public string PasswordHash { get; set; }

        public string SecurityStamp { get; set; }

        public string ConcurrencyStamp { get; set; }

        public string PhoneNumber { get; set; }

        public bool PhoneNumberConfirmed { get; set; }

        public bool TwoFactorEnabled { get; set; }

        public DateTimeOffset? LockoutEnd { get; set; }

        public bool LockoutEnabled { get; set; }

        public int AccessFailedCount { get; set; }

       
        public virtual ICollection<AspNetUserClaim> AspNetUserClaims { get; set; }
       
        public virtual ICollection<AspNetUserLogin> AspNetUserLogins { get; set; }

  
        public virtual ICollection<AspNetUserToken> AspNetUserTokens { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<AspNetRole> AspNetRoles { get; set; }

       
        //public virtual ICollection<AspNetUserRoles> AspNetUserRoles { get; set; }
 
        public virtual ICollection<AspNetUserRoles> AspNetUserRoles { get; set; }
    }

    public partial class AspNetRole
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public AspNetRole()
        //{
        //    //AspNetRoleClaims = new HashSet<AspNetRoleClaim>();
        //    //AspNetUsers = new HashSet<AspNetUser>();

        //    AspNetUserRoles = new HashSet<AspNetUserRoles>();       
        //}

        [Key]
        [StringLength(450)]
        public string Id { get; set; }

        [StringLength(256)]
        public string Name { get; set; }

        [StringLength(256)]
        public string NormalizedName { get; set; }

        public string ConcurrencyStamp { get; set; }

        //public virtual AspNetRoleClaims AspNetRoleClaims { get; set; }
        public virtual ICollection<AspNetUserRoles> AspNetUserRoles { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

        //public virtual ICollection<AspNetRoleClaim> AspNetRoleClaims { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<AspNetUser> AspNetUsers { get; set; }

        //public virtual ICollection<AspNetUserRoles> AspNetUserRoles { get; set; }

    }

    public partial class AspNetRoleClaim
    {
        public int Id { get; set; }

        [Required]
        [StringLength(450)]
        public string RoleId { get; set; }

        public string ClaimType { get; set; }

        public string ClaimValue { get; set; }

        public virtual AspNetRole AspNetRole { get; set; }
    }

    public partial class AspNetUserClaim
    {
        public int Id { get; set; }

        [Required]
        [StringLength(450)]
        public string UserId { get; set; }

        public string ClaimType { get; set; }

        public string ClaimValue { get; set; }

        public virtual AspNetUser AspNetUser { get; set; }
    }

    public partial class AspNetUserLogin
    {
        [Key]
        [Column(Order = 0)]
        public string LoginProvider { get; set; }

        [Key]
        [Column(Order = 1)]
        public string ProviderKey { get; set; }

        public string ProviderDisplayName { get; set; }

        [Required]
        [StringLength(450)]
        public string UserId { get; set; }

        public virtual AspNetUser AspNetUser { get; set; }
    }

    public partial class AspNetUserToken
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(450)]
        public string UserId { get; set; }

        [Key]
        [Column(Order = 1)]
        public string LoginProvider { get; set; }

        [Key]
        [Column(Order = 2)]
        public string Name { get; set; }

        public string Value { get; set; }

        public virtual AspNetUser AspNetUser { get; set; }
    }

}
