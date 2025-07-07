using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ymypprojects.Business.Constants;

public static class ResultMessages 
{
    //statik sınıfın içindeki yapılarda statik olmak zorunda 

    public static string SuccessCategoryCreated = "Kategori başarıyla eklendi";
    public static string SuccessCategoryUpdated = "Kategori başarıyla güncellendi";
    public static string SuccessCategoryDeleted = "Kategori başarıyla silindi";
    public static string SuccessCategoryListed  = "Kategori başarıyla listelendi";
    public static string SuccessCategoryGetById = "Kategori başarıyla getirildi";
    public static string ErrorCategoryCreated   = "Kategori başarıyla eklendi";
    public static string ErrorCategoryUpdated   = "Kategori başarıyla güncellendi";
    public static string ErrorCategoryDeleted   = "Kategori başarıyla silindi";
    public static string ErrorCategoryListed    = "Kategori başarıyla listelendi";
    public static string ErrorCategoryGetById   = "Seçilen kategori başarıyla getirildi";


    public static string SuccessMovieCreated = "Film başarıyla eklendi";
    public static string SuccessMovieUpdated = "Film başarıyla güncellendi";
    public static string SuccessMovieDeleted = "Film başarıyla silindi";
    public static string SuccessMovieListed  = "Film başarıyla listelendi";
    public static string SuccessMovieGetById = "Film başarıyla getirildi";
    public static string ErrorMovieCreated   = "Film başarıyla eklendi";
    public static string ErrorMovieUpdated   = "Film başarıyla güncellendi";
    public static string ErrorMovieDeleted   = "Film başarıyla silindi";
    public static string ErrorMovieListed    = "Film başarıyla listelendi";
    public static string ErrorMovieGetById = "Seçilen film başarıyla getirildi";

    public static string SuccessCreated = "Ekleme işlemi başarıyla tamamlandı";
}