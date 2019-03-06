using Softcode.Bdms.DataModel.Softcode.Bdms.DataModel;
using Softcode.Bdms.Repository;
using Softcode.Bdms.RequestModel;
using Softcode.Bdms.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Softcode.Bdms.ApplicationService
{
    public class BaseService<T, Tr, Tv>:IBaseService<T,Tr,Tv> where T : BaseEntity where Tr : BaseRequestModel<T> where Tv : BaseViewModel<T>
    {

        private readonly IBaseRepository<T> repository;
        public BaseService(IBaseRepository<T> repository)
        {
            this.repository = repository;
        }


        public IQueryable<T> SearchQueryable(BaseRequestModel<T> request)
        {
            IQueryable<T> queryable = repository.Get();
            queryable = request.IncludeParents(queryable);
            var expression = request.GetExpression();
            queryable = queryable.Where(expression);
            queryable = request.OrderByFunc()(queryable);
            queryable = request.SkipAndTake(queryable);

            return queryable;
        }

        

        public bool Add(T model)
        {
            
            return repository.Add(model);
        }

        public bool Edit(T model)
        {

            return repository.Edit(model);
        }

        public T GetById(int id)
        {

            return repository.GetDetail(id);
        }

        public string GetReferanceId()
        {
           var referenceNo = "";
           var queryable = repository.Get();
            var list = queryable.ToList();
            int count = list.Count();
            while (true)
            {
                count++;
                referenceNo = "M" + count.ToString().PadLeft(4, '0');
                return referenceNo;
            }
            
            
        }


        public bool Delete(int id)
        {

            return repository.Delete(id);
        }

        public Tv Detail(int id)
        {
             T x = repository.GetDetail(id);
           
            if (x == null)
            //id vul disos can
            {
                throw new Exception();
            }

            var vm = CreateVmInstance(x);

            return vm;
        }
    
        public List<Tv> Search(Tr request)
        {

            var queryable = SearchQueryable(request);

            var list = queryable.ToList().ConvertAll(CreateVmInstance);    //hit to database  and execute the query

            return list;
        }

        private static Tv CreateVmInstance(T x)
        {
            return (Tv)Activator.CreateInstance(typeof(Tv), x);
        }

        public HashSet<DropdownViewModel> GetDropdownList(Tr request)
        {
            IQueryable<T> queryable = repository.Get();
            queryable = request.OrderByFunc()(queryable);
            HashSet<DropdownViewModel> list = queryable.Select(request.Dropdown()).ToHashSet();
            return list;
        }

    }
}
