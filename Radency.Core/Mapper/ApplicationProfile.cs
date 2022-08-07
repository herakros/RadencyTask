using AutoMapper;
using Radency.Contracts.Data.Entities.BookEntity;
using Radency.Contracts.Data.Entities.RaitingEntity;
using Radency.Contracts.DTO;

namespace Radency.Core.Mapper
{
    public class ApplicationProfile : Profile
    {
        public ApplicationProfile()
        {
            CreateMap<CreateOrUpdateBookDTO, Book>()
                .ForMember(dest => dest.Title, act => act.MapFrom(src => src.Title))
                .ForMember(dest => dest.Cover, act => act.MapFrom(src => src.Cover))
                .ForMember(dest => dest.Content, act => act.MapFrom(src => src.Content))
                .ForMember(dest => dest.Genre, act => act.MapFrom(src => src.Genre))
                .ForMember(dest => dest.Author, act => act.MapFrom(src => src.Author));

            CreateMap<Book, BookDTO>()
                .ForMember(dest => dest.Id, act => act.MapFrom(src => src.Id))
                .ForMember(dest => dest.Title, act => act.MapFrom(src => src.Title))
                .ForMember(dest => dest.Cover, act => act.MapFrom(src => src.Cover))
                .ForMember(dest => dest.Content, act => act.MapFrom(src => src.Content))
                .ForMember(dest => dest.Genve, act => act.MapFrom(src => src.Genre))
                .ForMember(dest => dest.Author, act => act.MapFrom(src => src.Author))
                .ForMember(dest => dest.Rating, act => act.MapFrom(src => src.Raitings.Average(x => x.Score)));

            CreateMap<Review, ReviewDTO>()
                .ForMember(dest => dest.Id, act => act.MapFrom(src => src.Id))
                .ForMember(dest => dest.Message, act => act.MapFrom(src => src.Message))
                .ForMember(dest => dest.Reviewer, act => act.MapFrom(src => src.Reviewer));

            CreateMap<Book, OrderBookDTO>()
                .ForMember(dest => dest.Id, act => act.MapFrom(src => src.Id))
                .ForMember(dest => dest.Title, act => act.MapFrom(src => src.Title))
                .ForMember(dest => dest.Author, act => act.MapFrom(src => src.Author))
                .ForMember(dest => dest.ReviewsNumber, act => act.MapFrom(src => src.Reviews.Count))
                .ForMember(dest => dest.Raiting, act => act.MapFrom(src => src.Raitings.Average(x => x.Score)));

            CreateMap<AddReviewDTO, Review>()
                .ForMember(dest => dest.Message, act => act.MapFrom(src => src.Message))
                .ForMember(dest => dest.Reviewer, act => act.MapFrom(src => src.Reviewer));
        }
    }
}
