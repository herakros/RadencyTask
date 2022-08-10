export class BookView {
    id: number;
    title: string;
    cover: string;
    genre: string;
    author: string;
    content: string;
    raiting: number;
    reviews: Review[];
}

export class Review {
    id: number;
    message: string;
    reviewer: string;
}
