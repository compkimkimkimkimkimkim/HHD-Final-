using HHD.DataAccessLayer;
using HHD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HHD.BusinessLogicLayer
{
    public class CommunityBLL
    {
        public static bool CheckPassword(int id, string password)
        {
            Community community = CommunityDAL.GetCommunity(id);

            if (community != null && community.Password == password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Community GetCommunity(int id)
        {
            return CommunityDAL.GetCommunity(id);
        }

        public static List<CommunityCustom> GetCommunityList()
        {
            List<CommunityCustom> customs = new List<CommunityCustom>();
            var list = CommunityDAL.GetCommunityList();

            foreach (var item in list)
            {
                var comments = CommunityCommentDAL.GetCommunityCommentList(item.Id);

                CommunityCustom custom = new CommunityCustom()
                {
                    Id = item.Id,
                    Name = item.Name,
                    Password = item.Password,
                    Title = item.Title,
                    Content = item.Content,
                    CreationTime = item.CreationTime,
                    Pictures = CommunityPictureDAL.GetCommunityPictureList(item.Id),
                    CollectionCount = CommunityCollectionDAL.GetCount(item.Id),
                    Categories = CommunityCategoryDAL.GetCommunityCategoryList(item.Id),
                    Comments = comments,
                    CommentCount = comments.Count
                };
                customs.Add(custom);
            }

            return customs;
        }

        public static List<CommunityCustom> GetCommunityList(int categoryId)
        {
            List<CommunityCustom> customs = new List<CommunityCustom>();
            var list = categoryId == 0 ? CommunityDAL.GetCommunityList() : CommunityDAL.GetCommunityList(categoryId);

            foreach (var item in list)
            {
                var comments = CommunityCommentDAL.GetCommunityCommentList(item.Id);
                CommunityCustom custom = new CommunityCustom()
                {
                    Id = item.Id,
                    Name = item.Name,
                    Password = item.Password,
                    Title = item.Title,
                    Content = item.Content,
                    CreationTime = item.CreationTime,
                    Pictures = CommunityPictureDAL.GetCommunityPictureList(item.Id),
                    CollectionCount = CommunityCollectionDAL.GetCount(item.Id),
                    Categories = CommunityCategoryDAL.GetCommunityCategoryList(item.Id),
                    Comments = comments,
                    CommentCount = comments.Count
                };
                customs.Add(custom);
            }

            return customs;
        }

        public static List<CommunityCustom> GetCommunityList(int categoryId, int pageSize, int pageNum)
        {
            List<CommunityCustom> customs = new List<CommunityCustom>();
            var list = categoryId == 0 ? CommunityDAL.GetCommunityList(pageSize, pageNum) : CommunityDAL.GetCommunityList(categoryId, pageSize, pageNum);

            foreach (var item in list)
            {
                var comments = CommunityCommentDAL.GetCommunityCommentList(item.Id);
                CommunityCustom custom = new CommunityCustom()
                {
                    Id = item.Id,
                    Name = item.Name,
                    Password = item.Password,
                    Title = item.Title,
                    Content = item.Content,
                    CreationTime = item.CreationTime,
                    Pictures = CommunityPictureDAL.GetCommunityPictureList(item.Id),
                    CollectionCount = CommunityCollectionDAL.GetCount(item.Id),
                    Categories = CommunityCategoryDAL.GetCommunityCategoryList(item.Id),
                    Comments = comments,
                    CommentCount = comments.Count
                };
                customs.Add(custom);
            }

            return customs;
        }


        public static List<CommunityCustom> GetCommunityListAdmin(int categoryId)
        {
            List<CommunityCustom> customs = new List<CommunityCustom>();
            var list = categoryId == 0 ? CommunityDAL.GetCommunityList() : CommunityDAL.GetCommunityList();

            foreach (var item in list)
            {
                var comments = CommunityCommentDAL.GetCommunityCommentList(item.Id);
                CommunityCustom custom = new CommunityCustom()
                {
                    Id = item.Id,
                    Name = item.Name,
                    Password = item.Password,
                    Title = item.Title,
                    Content = item.Content,
                    CreationTime = item.CreationTime,
                    Pictures = CommunityPictureDAL.GetCommunityPictureList(item.Id),
                    CollectionCount = CommunityCollectionDAL.GetCount(item.Id),
                    Categories = CommunityCategoryDAL.GetCommunityCategoryList(item.Id),
                    Comments = comments,
                    CommentCount = comments.Count
                };
                customs.Add(custom);
            }

            return customs;
        }

        public static int AddCommunity(Community community)
        {
            return CommunityDAL.AddCommunity(community);
        }

        public static bool UpdateCommunity(Community community)
        {
            return CommunityDAL.UpdateCommunity(community);
        }

        public static bool DeleteCommunity(int id)
        {
            var result = CommunityDAL.DeleteCommunity(id);

            if (result)
            {
                CommunityCategoryDAL.DeleteCommunityCategory(id);
                CommunityCollectionDAL.DeleteCommunityCollection(id);
                CommunityCommentDAL.DeleteCommunityComment(id);
                CommunityPictureDAL.DeleteCommunityPicture(id);
            }

            return result;
        }
        public static Community GetByIdDTO(int id)
        {
            return CommunityDAL.GetById(id);
        }
    }
}