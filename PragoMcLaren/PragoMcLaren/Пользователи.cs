//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PragoMcLaren
{
    using System;
    using System.Collections.Generic;
    
    public partial class Пользователи
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Пользователи()
        {
            this.Клиенты = new HashSet<Клиенты>();
            this.Сотрудники = new HashSet<Сотрудники>();
        }
    
        public int IDПользователя { get; set; }
        public string Логин { get; set; }
        public string Пароль { get; set; }
        public string Роль { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Клиенты> Клиенты { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Сотрудники> Сотрудники { get; set; }
    }
}
