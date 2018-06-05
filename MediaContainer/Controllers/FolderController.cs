using MediaContainer.Models;
using MediaContainer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace MediaContainer.Controllers
{
    public class FolderController : ApiController
    {
        //GET
        [HttpGet]
        [Route("~/media/folder/{ID}")]
        public async Task<IHttpActionResult> GetFolder(int ID)
        {
            try
            {
                MediaContainerRepository repo = new MediaContainerRepository();
                var response = repo.GetFolder(ID);
                if (response != null)
                {
                    return Ok(response);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return BadRequest("An error occurred in GetFolder: " + ex.Message);
            }
        }

        //GET
        [HttpGet]
        [Route("~/media/folder/user/{userID}")]
        public async Task<IHttpActionResult> GetFolders(int userID)
        {
            try
            {
                MediaContainerRepository repo = new MediaContainerRepository();
                var response = repo.GetFolders(userID);
                if (response != null)
                {
                    return Ok(response);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return BadRequest("An error occurred in GetFolders: " + ex.Message);
            }
        }

        //CREATE
        [HttpPost]
        [Route("~/media/folder")]
        public async Task<IHttpActionResult> CreateFolders(List<Folder> folders)
        {
            try
            {
                MediaContainerRepository repo = new MediaContainerRepository();
                var response = repo.CreateFolders(folders);
                if (response != null)
                {
                    return Ok(response);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return BadRequest("An error occurred in CreateFolders: " + ex.Message);
            }
        }
        //UPDATE
        [HttpPost]
        [Route("~/media/folder")]
        public async Task<IHttpActionResult> UpdateFolders(List<Folder> folders)
        {
            try
            {
                MediaContainerRepository repo = new MediaContainerRepository();
                var response = repo.UpdateFolders(folders);
                if (response != null)
                {
                    return Ok(response);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return BadRequest("An error occurred in UpdateFolders: " + ex.Message);
            }
        }
        //DELETE

        [HttpDelete]
        [Route("~/media/folder/{ID}")]
        public async Task<IHttpActionResult> DeleteFolder(int ID)
        {
            try
            {
                MediaContainerRepository repo = new MediaContainerRepository();
                var response = repo.DeleteFolder(ID);
                if (response != null)
                {
                    return Ok(response);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return BadRequest("An error occurred in DeleteFolder: " + ex.Message);
            }
        }
    }
}