//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyZp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Friends
    {
        public int ID { get; set; }
        public int User_ID { get; set; }
        public int Friend_ID { get; set; }
        public int FriendStatus_ID { get; set; }
    
        public virtual FriendStatus FriendStatus { get; set; }
        public virtual Users Users { get; set; }
        public virtual Users Users1 { get; set; }
    }
}