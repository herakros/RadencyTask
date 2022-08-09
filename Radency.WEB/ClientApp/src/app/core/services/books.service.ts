import { Inject, Injectable } from "@angular/core";
import { HttpClient } from '@angular/common/http';
import { Book } from '../models/book';
import { bookServiceUrl } from "src/app/configs/api-endpoints";

@Injectable({
    providedIn: 'root'
  })
  export class BooksService {
    constructor(private http: HttpClient) { }

    add(book: Book) {
        return this.http.post(`${bookServiceUrl}books/save`, book);
    }

    getSingle(bookId: number) {
        return this.http.get(`${bookServiceUrl}books/${bookId}`);
    }
  }