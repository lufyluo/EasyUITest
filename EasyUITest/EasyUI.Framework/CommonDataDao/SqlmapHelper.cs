using System;
using IBatisNet.DataMapper;

namespace EasyUI.Framework.CommonDataDao
{
    public abstract class  SqlmapHelper
    {
        private static  readonly object Lockkey = new object();

        private static ISqlMapper sqlMap;
        public static void Init()
        {
            try
            {
                sqlMap = Mapper.Instance();
                sqlMap.SessionStore = new IBatisNet.DataMapper.SessionStore.CallContextSessionStore(sqlMap.Id);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static ISqlMapper Instance
        {
            get
            {
                if (sqlMap == null)
                {
                    lock (Lockkey)
                    {
                        Init();
                    }
                }
                return sqlMap;
            }
            
        }
    }
    
}
