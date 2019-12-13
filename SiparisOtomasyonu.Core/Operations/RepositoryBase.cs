using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using SiparisOtomasyonu.Core.DataAccess.Abstract;
using SiparisOtomasyonu.Core.Operations.Helpers;
using SiparisOtomasyonu.Entities.Entity;
using SiparisOtomasyonu.Entities.Entity.Abstract;
using SiparisOtomasyonu.Entities.Entity.Enums;

namespace SiparisOtomasyonu.Core.Operations
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity>
        where TEntity : class, IEntity
    {
        private PathModel _pathModel;
        public DirectoryHelper _directoryHelper;
        public FileHelper _fileHelper;

        public List<TEntity> Entities { get; set; }
        public RepositoryBase(PathModel pathModel)
        {

            _pathModel = pathModel;
            _directoryHelper = new DirectoryHelper(_pathModel.Path, pathModel.DirectoryName);
            _fileHelper = new FileHelper(_pathModel.Path + "\\" + _pathModel.DirectoryName, _pathModel.FileName);
            Entities = GetAll();
            if (Entities == null)
            {
                Entities = new List<TEntity>();
            }
            PathCheck();
        }

        public virtual List<TEntity> GetAll()
        {
            string jsonText = _fileHelper.FileRead();
            List<TEntity> entities = JsonParseHelper<TEntity>.GetDeserializeList(jsonText);
            return entities;
        }
        public List<T> GetAll<T>() where T : class, new()
        {
            string jsonText = _fileHelper.FileRead();
            List<T> entities = JsonParseHelper<T>.GetDeserializeList(jsonText);
            return entities;
        }
        public List<TEntity> GetByFilter(Expression<Func<TEntity, bool>> filter)
        {

            List<TEntity> entity = Entities.AsQueryable().Where(filter).ToList();
            return entity;
        }

        public virtual Result Add(TEntity entity)
        {
            return UseTryCatch.Use(() =>
            {
                Entities.Add(entity);
                Sync();
            });


        }

        public virtual Result Delete(int index)
        {
            return UseTryCatch.Use(() =>
            {
                Entities.RemoveAt(index);
                Sync();
            });
        }


        public void PathCheck()
        {
            if (_directoryHelper.DirectoryExists())
            {
                if (!_fileHelper.FileExists())
                {
                    _fileHelper.Create();
                }
            }
            else
            {
                _directoryHelper.Create();
                _fileHelper.Create();
            }
        }
        public void Sync()
        {
            string jsonText = JsonParseHelper<TEntity>.GetSerializeList(Entities);
            _fileHelper.FileWrite(jsonText);
        }
    }
}
