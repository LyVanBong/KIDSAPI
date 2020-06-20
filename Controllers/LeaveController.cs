﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using KIDS.API.Database;
using KIDS.API.Models;

namespace KIDS.API.Controllers
{
    [RoutePrefix("api/v1")]
    public class LeaveController : ApiController
    {
        /// <summary>
        /// Api lấy danh sách đơn xin nghỉ học
        /// </summary>
        /// <param name="TeacherId"></param>
        /// <param name="ClassId"></param>
        /// <returns></returns>
        [Route("Leave")]
        [HttpGet]
        public IHttpActionResult LeaveSchool(Guid TeacherId, Guid ClassId)
        {
            var db = new H_KIDSEntities();
            var data = db.sp_Teacher_Application_sel(ClassId, TeacherId).ToList();
            if (data.Any())
            {
                return Ok(new ResponseModel<List<sp_Teacher_Application_sel_Result>>()
                {
                    Code = 2,
                    Message = "Get data leave school successfully",
                    Data = data,
                });
            }
            return Ok(new ResponseModel<List<sp_Teacher_Application_sel_Result>>()
            {
                Code = -3,
                Message = "Get data leave school error",
                Data = null,
            });
        }
    }
}
