//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Data
//{
//    internal class Class1
//    {
//        public APIResponse ImportExc(IFormFile formFile)
//        {
//            if (formFile == null || formFile.Length <= 0)
//            {
//                return new APIResponse
//                {
//                    IsError = true,
//                    Message = "الملف فارغ",

//                    Code = 400
//                };//BadRequest("No File");
//            }

//            if (!Path.GetExtension(formFile.FileName).Equals(".xlsx", StringComparison.OrdinalIgnoreCase))
//            {
//                return new APIResponse
//                {
//                    IsError = true,
//                    Message = "الرجاء إختيار صيغة إكسيل صحيحة",

//                    Code = 400
//                };// BadRequest("Not support File Extension");
//            }
//            try
//            {
//                var list = new List<workOrdersInput>();

//                using (var stream = new MemoryStream())
//                {
//                    formFile.CopyToAsync(stream);

//                    using (var package = new ExcelPackage(stream))
//                    {
//                        ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
//                        var rowCount = worksheet.Dimension.Rows;
//                       // var AllCaseId = uow.workOrdersRepo.Get().Select(W => W.CASE_ID);

//                        for (int row = 2; row <= rowCount; row++)
//                        {
//                            //if (String.IsNullOrWhiteSpace(worksheet.Cells[row, 6].Value?.ToString()))
//                            //    break;

//                            //var obj = new workOrdersInput();
//                            //DateTime? x = worksheet.Cells[row, 14]?.Text == null ? null : Convert.ToDateTime(worksheet.Cells[row, 14]?.Text);

//                            //obj.CASE_ID = worksheet.Cells[row, 6].Value.ToString().Trim();
//                            //if (AllCaseId.Contains(obj.CASE_ID))
//                            //    return new APIResponse
//                                //{
//                                //    IsError = true,
//                                //    Message = " مكررة Case Id",

//                                //    Code = 400
//                                //};
//                            obj.CBU = worksheet.Cells[row, 1].Value?.ToString().Trim();
//                            obj.CUSTOMER_CLASS = worksheet.Cells[row, 3].Value?.ToString().Trim();
//                            obj.STATUS = worksheet.Cells[row, 13].Value?.ToString().Trim();
//                            obj.CONNECTION_TYPE = worksheet.Cells[row, 5].Value?.ToString().Trim();
//                            obj.ACCT_ID = worksheet.Cells[row, 2].Value?.ToString().Trim();
//                            obj.ORDER_NO = worksheet.Cells[row, 7].Value?.ToString().Trim();
//                            obj.SEWER_SA_STATUS = worksheet.Cells[row, 9].Value?.ToString().Trim();
//                            obj.HCN = worksheet.Cells[row, 10].Value?.ToString().Trim();
//                            obj.WATER_SA_STATUS = worksheet.Cells[row, 8].Value?.ToString().Trim();
//                            obj.CASE_STATUS_CD = worksheet.Cells[row, 11].Value?.ToString().Trim();
//                            obj.REQUEST_DATE = worksheet.Cells[row, 14]?.Value == null ? null : Convert.ToDateTime(worksheet.Cells[row, 14]?.Text);
//                            obj.PAYMENT_DATE = worksheet.Cells[row, 15]?.Value == null ? null : Convert.ToDateTime(worksheet.Cells[row, 15]?.Text);
//                            obj.MTR_ACTIVATION_DATE = worksheet.Cells[row, 16]?.Value == null ? null : Convert.ToDateTime(worksheet.Cells[row, 16]?.Text);
//                            obj.INSTALLATION_DATE = worksheet.Cells[row, 17]?.Value == null ? null : Convert.ToDateTime(worksheet.Cells[row, 17]?.Text);
//                            obj.PAYMENT_TO_INSTALLATION = worksheet.Cells[row, 18].Value?.ToString().Trim();
//                            obj.METER_ID = worksheet.Cells[row, 19].Value?.ToString().Trim();
//                            obj.CONNECTION_FEES = worksheet.Cells[row, 20].Value?.ToString().Trim();
//                            obj.Districted_Name = worksheet.Cells[row, 21].Value?.ToString().Trim();
//                            obj.CUSTOMER_NAME = worksheet.Cells[row, 23].Value?.ToString().Trim();
//                            list.Add(obj);
//                        }
//                    }
//                }
//                uow.workOrdersRepo.Insert(mapper.Map<List<workOrders>>(list));
//                uow.Save();
//                return new APIResponse
//                {
//                    IsError = false,
//                    Message = "تمت الاضافة",
//                    Data = true,
//                    Code = 200
//                };
//            }
//            catch (Exception ex)
//            {
//                // insert ex exception in databse Error Log Table
//                return new APIResponse
//                {
//                    IsError = true,
//                    Message = ex.Message,

//                    Code = 500
//                };
//            }
//        }
//    }
//}
