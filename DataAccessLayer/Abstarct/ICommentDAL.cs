﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstarct
{
    public interface ICommentDAL:IGenericDAL<Comment>
    {
        List<Comment> GetListWithBlog();
    }
}