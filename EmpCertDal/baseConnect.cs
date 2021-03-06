﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpCertDal
{
    public class BaseConnect : IDisposable
    {
        private EmployeeCertContext _cntx;

        public EmployeeCertContext cntx
        {
            get
            {
                if (_cntx == null)
                {
                    _cntx = new EmployeeCertContext();
                }
                return _cntx;
            }
        }
        public BaseConnect()
        {
            CreatedDate = DateTime.Now;
            ModifiedDate = DateTime.Now;
        }
 
        [Key]
        public virtual int Id { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }

        [Required]
        public DateTime ModifiedDate { get; set; }

        public void Dispose()
        {
         
        }
    }
}
