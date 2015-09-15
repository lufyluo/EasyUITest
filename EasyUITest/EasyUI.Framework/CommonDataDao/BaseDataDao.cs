using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Exceptions;

namespace EasyUI.Framework.CommonDataDao
{
    public class BaseDataDao : SqlmapHelper
    {
        private readonly ISqlMapper sqlMapper;

        protected BaseDataDao()
        {
            try
            {
                sqlMapper = Instance;
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public IList<T> ExecuteQueryForList<T>(string sta, object obj = null)
        {
            try
            {
                return sqlMapper.QueryForList<T>(sta, obj);
            }
            catch (Exception e)
            {
                throw new DataMapperException("Error executing query '" + sta + "' for list.  Cause: " + e.Message, e);
            }
        }

        public object ExecuteInsert(string sta, object obj)
        {
            try
            {
                return sqlMapper.Insert(sta, obj);
            }
            catch (Exception e)
            {
                throw new DataMapperException("Error executing insert '" + sta + "' for list.  Cause: " + e.Message, e);
            }
        }

        public object ExecuteUpdate(string sta, object obj)
        {
            try
            {
                return sqlMapper.Update(sta, obj);
            }
            catch (Exception e)
            {
                throw new DataMapperException("Error executing update '" + sta + "' for list.  Cause: " + e.Message, e);
            }
        }
    }
}
