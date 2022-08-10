import { Injectable } from "@angular/core";
import { HttpClient, HttpParams } from '@angular/common/http';
import { CreateOrUpdateBook } from '../models/createOrUpdateBook';
import { bookServiceUrl } from "src/app/configs/api-endpoints";
import { AddBookReview } from "../models/addBookReview";
import { AddBookRating } from "../models/addBookRating";
import { OrderByBook } from "../models/queries/orderByBook";
import { OrderByGenre } from "../models/queries/orderByGenre";
import { SecretKey } from "../models/queries/secretKey";
import { OrderBook } from "../models/orderBooks";
import { Observable } from "rxjs";
import { BookView } from "../models/bookView";

@Injectable({
    providedIn: 'root'
  })
  export class BooksService {
    constructor(private http: HttpClient) { }

    add(book: CreateOrUpdateBook) {
        return this.http.post(`${bookServiceUrl}books/save`, book);
    }

    getSingle(bookId: number) : Observable<BookView> {
        return this.http.get<BookView>(`${bookServiceUrl}books/${bookId}`);
    }

    getAllBooks(query: OrderByBook) : Observable<OrderBook[]>{
      let params = new HttpParams().set('Order', query.order);

      return this.http.get<OrderBook[]>(`${bookServiceUrl}books`, {params});
    }

    getRecommendedBooks(query: OrderByGenre) : Observable<OrderBook[]>{
      let params = new HttpParams().set('Genre', query.gerne);

      return this.http.get<OrderBook[]>(`${bookServiceUrl}recommended`, {params});
    }

    deleteBook(bookId: number, secretKey: SecretKey) {
      let params = new HttpParams().set('Key', secretKey.key);

      return this.http.delete(`${bookServiceUrl}books/${bookId}`, {params});
    }

    addBookReview(bookId: number, review: AddBookReview) {
      return this.http.put(`${bookServiceUrl}books/${bookId}/review`, review);
    }

    addBookRate(bookId: number, rate: AddBookRating) {
      return this.http.put(`${bookServiceUrl}books/${bookId}/rate`, rate);
    }
  }