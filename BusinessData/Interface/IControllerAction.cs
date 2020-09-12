using System.Web.Mvc;

namespace BusinessData.Interface
{
    public interface IControllerAction<T>
    {
        JsonResult Search(T dataItem);
        JsonResult Insert(T dataItem);
        JsonResult Update(T dataItem);
        JsonResult Delete(T dataItem);
    }
}