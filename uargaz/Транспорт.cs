//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace uargaz
{
    using System;
    using System.Collections.Generic;
    
    public partial class Транспорт
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Транспорт()
        {
            this.Бригада = new HashSet<Бригада>();
        }
    
        public int Код { get; set; }
        public string Тип { get; set; }
        public Nullable<int> Вместимость { get; set; }
        public Nullable<int> Код_Аварийная_работа { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Бригада> Бригада { get; set; }
    }
}
