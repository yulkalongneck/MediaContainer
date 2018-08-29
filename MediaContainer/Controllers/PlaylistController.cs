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

//Controller Functions

namespace MediaContainer.Controllers
{
    public class PlaylistController : ApiController
    {
        //GET
        [HttpGet]
        [Route("~/media/playlist/{ID}")]
        public async Task<IHttpActionResult> GetPlaylist(int ID)
        {
            try
            {
                MediaContainerRepository repo = new MediaContainerRepository();
                var response = repo.GetPlaylist(ID);
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
                return BadRequest("An error occurred in GetPlaylist: " + ex.Message);
            }
        }

        //GET
        [HttpGet]
        [Route("~/media/playlist/user/{userID}")]
        public async Task<IHttpActionResult> GetPlaylists(int userID)
        {
            try
            {
                MediaContainerRepository repo = new MediaContainerRepository();
                var response = repo.GetPlaylists(userID);
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
                return BadRequest("An error occurred in GetPlaylists: " + ex.Message);
            }
        }

        //CREATE
        [HttpPost]
        [Route("~/media/playlist")]
        public async Task<IHttpActionResult> CreatePlaylists(List<Playlist> playlists)
        {
            try
            {
                MediaContainerRepository repo = new MediaContainerRepository();
                var response = repo.CreatePlaylists(playlists);
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
                return BadRequest("An error occurred in CreatePlaylists: " + ex.Message);
            }
        }
        //UPDATE
        [HttpPut]
        [Route("~/media/playlist")]
        public async Task<IHttpActionResult> UpdatePlaylists(List<Playlist> playlists)
        {
            try
            {
                MediaContainerRepository repo = new MediaContainerRepository();
                var response = repo.UpdatePlaylists(playlists);
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
                return BadRequest("An error occurred in UpdatePlaylists: " + ex.Message);
            }
        }

        //DELETE
        [HttpDelete]
        [Route("~/media/playlist/{ID}")]
        public async Task<IHttpActionResult> DeletePlaylist(int ID)
        {
            try
            {
                MediaContainerRepository repo = new MediaContainerRepository();
                var response = repo.DeletePlaylist(ID);
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
                return BadRequest("An error occurred in DeletePlaylist: " + ex.Message);
            }
        }
    }
}
