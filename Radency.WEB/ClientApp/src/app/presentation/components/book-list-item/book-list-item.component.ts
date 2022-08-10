import { Component, Input, OnInit } from '@angular/core';
import { OrderBook } from 'src/app/core/models/orderBooks';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { ViewBookComponent } from '../view-book/view-book.component';

@Component({
  selector: 'app-book-list-item',
  templateUrl: './book-list-item.component.html',
  styleUrls: ['./book-list-item.component.css']
})
export class BookListItemComponent implements OnInit {

  @Input() public book: OrderBook;

  constructor(public dialog: MatDialog) { }

  ngOnInit() {
  }

  viewBook() {
    let dialogConfig = new MatDialogConfig();
    dialogConfig.data = {
      bookId: 1
    };

    this.dialog.open(ViewBookComponent, dialogConfig);
  }
}
