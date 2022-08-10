import { Component, OnInit } from '@angular/core';
import { OrderBook } from 'src/app/core/models/orderBooks';
import { OrderByBook } from 'src/app/core/models/queries/orderByBook';
import { OrderByGenre } from 'src/app/core/models/queries/orderByGenre';
import { BooksService } from 'src/app/core/services/books.service';

@Component({
  selector: 'app-books-page',
  templateUrl: './books-page.component.html',
  styleUrls: ['./books-page.component.css']
})
export class BooksPageComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }
}
