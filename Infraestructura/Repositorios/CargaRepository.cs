﻿using Dominio.Entidades;
using Dominio.Entidades.Carga;
using Dominio.Repositorios.Contratos;
using Helpers;
using Infraestructura.Core;
using Infraestructura.Data;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Infraestructura.Repositorios
{
    public class CargaRepository<TEntity> :RepositoryBase<Carga> , ICargaRepository<TEntity> where TEntity :class 
    {

        public CargaRepository(UniversidadContext universidadContext) : base(universidadContext)
        {

        }

        //public List<T> ObtenerWorkSheet(HttpPostedFileBase httpPostedFileBase) {

        //   // string file = @"D:\ForVideos\Demo\cs\data2.xlsx";

        //    ExcelWorksheet excelWorksheet;

        //    Stream streamFile = httpPostedFileBase.InputStream;

        //    MemoryStream ms;

        //    List<T> list = new List<T>();

        //    try
        //    {
        //        using (Stream inputStream = httpPostedFileBase.InputStream)
        //        {
        //            ms = new MemoryStream();
        //            inputStream.CopyTo(ms);
        //            using (var package = new ExcelPackage(ms))
        //            {
        //                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

        //                excelWorksheet = package.Workbook.Worksheets[2];                        

        //                var columnInfo = Enumerable.Range(1, excelWorksheet.Dimension.Columns).ToList().Select(n =>

        //                    new { Index = n, ColumnName = excelWorksheet.Cells[1, n].Value.ToString() }
        //                );

        //                for (int row = 2; row < excelWorksheet.Dimension.Rows; row++)
        //                {
        //                    T obj = (T)Activator.CreateInstance(typeof(T));//generic object
        //                    foreach (var prop in typeof(T).GetProperties())
        //                    {
        //                        int col = columnInfo.SingleOrDefault(c => c.ColumnName == prop.Name).Index;
        //                        var val = excelWorksheet.Cells[row, col].Value;
        //                        var propType = prop.PropertyType;
        //                        prop.SetValue(obj, Convert.ChangeType(val, propType));
        //                    }
        //                    list.Add(obj);
        //                }


        //                //var columnas = excelWorksheet.Dimension.Columns;

        //                //var columnInfo = Enumerable.Range(1, excelWorksheet.Dimension.Columns).ToList().Select(n =>

        //                //new { Index = n, ColumnName = excelWorksheet.Cells[1, n].Value.ToString() });


        //            }

        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw;
        //    }

        //    return list;
        //}

        public List<T> ObtenerWorkSheet<T>(HttpPostedFileBase httpPostedFileBase)
        {
            // string file = @"D:\ForVideos\Demo\cs\data2.xlsx";

            ExcelWorksheet excelWorksheet;

            Stream streamFile = httpPostedFileBase.InputStream;

            MemoryStream ms;

            List<T> list = new List<T>();

            try
            {
                using (Stream inputStream = httpPostedFileBase.InputStream)
                {
                    ms = new MemoryStream();
                    inputStream.CopyTo(ms);
                    using (var package = new ExcelPackage(ms))
                    {
                        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                        excelWorksheet = package.Workbook.Worksheets[0];

                        var columnInfo = Enumerable.Range(1, excelWorksheet.Dimension.Columns).ToList().Select(n =>

                            new { Index = n, ColumnName = excelWorksheet.Cells[1, n].Value.ToString() }
                        );

                        for (int row = 2; row < excelWorksheet.Dimension.Rows; row++)
                        {
                            T obj = (T)Activator.CreateInstance(typeof(T));//generic object
                            foreach (var prop in typeof(T).GetProperties())
                            {
                                int col = columnInfo.SingleOrDefault(c => c.ColumnName == prop.Name).Index;
                                var val = excelWorksheet.Cells[row, col].Value;
                                var propType = prop.PropertyType;
                                prop.SetValue(obj, Convert.ChangeType(val, propType));
                            }
                            list.Add(obj);
                        }


                        //var columnas = excelWorksheet.Dimension.Columns;

                        //var columnInfo = Enumerable.Range(1, excelWorksheet.Dimension.Columns).ToList().Select(n =>

                        //new { Index = n, ColumnName = excelWorksheet.Cells[1, n].Value.ToString() });


                    }

                }
            }
            catch (Exception ex)
            {

                throw;
            }

            return list;
        }

        //private List<T> ObtenerListaWS<T>(ExcelWorksheet sheet)
        //{
        //    List<T> list = new List<T>();

        //    var columnInfo = Enumerable.Range(1, sheet.Dimension.Columns).ToList().Select(n =>

        //        new { Index = n, ColumnName = sheet.Cells[1, n].Value.ToString() }
        //    );

        //    for (int row = 2; row < sheet.Dimension.Rows; row++)
        //    {
        //        T obj = (T)Activator.CreateInstance(typeof(T));//generic object
        //        foreach (var prop in typeof(T).GetProperties())
        //        {
        //            int col = columnInfo.SingleOrDefault(c => c.ColumnName == prop.Name).Index;
        //            var val = sheet.Cells[row, col].Value;
        //            var propType = prop.PropertyType;
        //            prop.SetValue(obj, Convert.ChangeType(val, propType));
        //        }
        //        list.Add(obj);
        //    }

        //    return list;
        //}

        //List<T> ICargaRepository<TEntity>.ObtenerListaWS<T>(ExcelWorksheet sheet)
        //{
        //    List<T> list = new List<T>();

        //    var columnInfo = Enumerable.Range(1, sheet.Dimension.Columns).ToList().Select(n =>

        //        new { Index = n, ColumnName = sheet.Cells[1, n].Value.ToString() }
        //    );

        //    for (int row = 2; row < sheet.Dimension.Rows; row++)
        //    {
        //        T obj = (T)Activator.CreateInstance(typeof(T));//generic object
        //        foreach (var prop in typeof(T).GetProperties())
        //        {
        //            int col = columnInfo.SingleOrDefault(c => c.ColumnName == prop.Name).Index;
        //            var val = sheet.Cells[row, col].Value;
        //            var propType = prop.PropertyType;
        //            prop.SetValue(obj, Convert.ChangeType(val, propType));
        //        }
        //        list.Add(obj);
        //    }

        //    return list;
        //}



        /*public List<T> SubirArchivo(TEntity T, string nombreArchivo )
        {
            List<TEntity> genericList = new List<TEntity>();

            int contador = 1;
            IDictionary<int, string> mapeoExcel = new Dictionary<int, string>();
            mapeoExcel.Add(1, "CodigoAlumno");
            mapeoExcel.Add(2, "NombreAlumno");
            mapeoExcel.Add(3, "ApePaternoAlumno");
            mapeoExcel.Add(4, "ApeMaternoAlumno");
            mapeoExcel.Add(5, "MailAlumno");
            mapeoExcel.Add(6, "TelefonoAlumno");

            AsistenciaEvento obj1 = new AsistenciaEvento()
            {
                Id = 1,
                CodigoAlumno = "C01",
                NombreAlumno = "Nombre1",
                ApePaternoAlumno = "Ape1",
                ApeMaternoAlumno = "Ape11",
                MailAlumno = "mail1",
                TelefonoAlumno = "tel1"
            };

            AsistenciaEvento obj2 = new AsistenciaEvento()
            {
                Id = 1,
                CodigoAlumno = "C02",
                NombreAlumno = "Nombre1",
                ApePaternoAlumno = "Ape2",
                ApeMaternoAlumno = "Ape22",
                MailAlumno = "mail2",
                TelefonoAlumno = "tel2"
            };


            IDictionary<int, AsistenciaEvento> asistenciaEventoDic = new Dictionary<int, AsistenciaEvento>();
            asistenciaEventoDic.Add(1, obj1);
            asistenciaEventoDic.Add(2, obj2);

            Genericos<TEntity> genericos = new Genericos<TEntity>();

            foreach (var propiedades in obj2.GetType().GetProperties())
            {

                TEntity entity = genericos.GetObject<TEntity>();

                foreach (var propiedad in entity.GetType().GetProperties())
                {
                    if (propiedades.Name == propiedad.Name)
                    {
                        propiedad.SetValue(entity, Convert.ChangeType(propiedades.GetValue(entity, null), propiedad.PropertyType), null);
                    }
                    //Mapeamos las propiedades con sus nombres
                    var propiedadNombre = propiedad.Name;
                    var propiedadValor = propiedad.GetValue(T);
                    var tipoDato = propiedad.PropertyType.ToString();

                }

                genericList.Add(entity);
            }

            var x== this.Contenedor();

            mapeoExcel.Values.Equals("");

            string[] estructuraGeneral = new string [] { };

            ArrayExtensiones arrayExtensiones = new ArrayExtensiones();

            foreach (var propiedadLista in genericList.ToArray())
            {
                var y = propiedadLista.GetType().Attributes.ToString();
            }


            foreach (var propiedad in T.GetType().GetProperties())
            { 
                //Mapeamos las propiedades con sus nombres
                var propiedadNombre = propiedad.Name;
                var propiedadValor = propiedad.GetValue(T);
                var tipoDato = propiedad.PropertyType.ToString();
                
                arrayExtensiones.ArrayPush(ref estructuraGeneral, propiedadNombre);

            }

            using (var stream = new MemoryStream())
            {
                // await formFile.CopyToAsync(stream, cancellationToken);
                // Copiamos el archivo HttpPostedBase a Stream
                // httpPostedFileBase.InputStream.CopyTo(stream);

                using (var package = new ExcelPackage(stream))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                    var rowCount = worksheet.Dimension.Rows;
                    var columnCount = worksheet.Dimension.Columns;
                    
                    for (int row = 2; row <= rowCount; row++)
                    {
                        foreach (KeyValuePair<int, string> entry in mapeoExcel)
                        {
                                                  
                        }
                    }

                    

                }
            }

            var x= "nameof(Campus.IdCampus),nameof(Campus.NombreCampus)";

            var copyParameters = new[]
            {nameof(Campus.IdCampus),nameof(Campus.NombreCampus)};

            return true;


            
        }

 */
    }
}
 