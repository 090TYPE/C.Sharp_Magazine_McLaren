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
    
    public partial class Автомобили
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Автомобили()
        {
            this.Продажи = new HashSet<Продажи>();
            this.СервисныеВизиты = new HashSet<СервисныеВизиты>();
            this.СкладАвтомобилей = new HashSet<СкладАвтомобилей>();
            this.ТестДрайвы = new HashSet<ТестДрайвы>();
            this.ФинансовыеУсловия = new HashSet<ФинансовыеУсловия>();
        }
    
        public int IDАвтомобиля { get; set; }
        public string Модель { get; set; }
        public Nullable<int> Год { get; set; }
        public string Цвет { get; set; }
        public string ТипДвигателя { get; set; }
        public Nullable<int> Мощность { get; set; }
        public Nullable<decimal> Цена { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Продажи> Продажи { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<СервисныеВизиты> СервисныеВизиты { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<СкладАвтомобилей> СкладАвтомобилей { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ТестДрайвы> ТестДрайвы { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ФинансовыеУсловия> ФинансовыеУсловия { get; set; }
    }
}
