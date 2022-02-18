using Dominio.Entidades;
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


        public List<T> ObtenerWorkSheet<T>(HttpPostedFileBase httpPostedFileBase)
        {

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

                        excelWorksheet = package.Workbook.Worksheets[3];

                        var columnInfo = Enumerable.Range(1, excelWorksheet.Dimension.Columns).ToList().Select(n =>

                            new { Index = n, ColumnName = excelWorksheet.Cells[1, n].Value.ToString() }
                        );

                        for (int row = 2; row < excelWorksheet.Dimension.Rows; row++)
                        {
                            T obj = (T)Activator.CreateInstance(typeof(T));
                            foreach (var prop in typeof(T).GetProperties())
                            {
                                int col = columnInfo.SingleOrDefault(c => c.ColumnName == prop.Name).Index;
                                var val = excelWorksheet.Cells[row, col].Value;
                                var propType = prop.PropertyType;
                                prop.SetValue(obj, Convert.ChangeType(val, propType));
                            }
                            list.Add(obj);
                        }
                    }

                }
            }
            catch (Exception ex)
            {

                throw;
            }

            return list;
        }

        
    }
}
 