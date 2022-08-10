import { Component, Inject, Input, OnInit } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { BookView } from 'src/app/core/models/bookView';
import { BooksService } from 'src/app/core/services/books.service';

@Component({
  selector: 'app-view-book',
  templateUrl: './view-book.component.html',
  styleUrls: ['./view-book.component.css']
})
export class ViewBookComponent implements OnInit {

  bookId: number;
  book: BookView;

  constructor(private bookService: BooksService,
    private dialogRef: MatDialogRef<ViewBookComponent>,
    @Inject(MAT_DIALOG_DATA) data: any) {
      this.bookId = data.bookId;
      this.bookService.getSingle(this.bookId).subscribe((data: BookView) => {
        this.book = data;
      })
    }

  ngOnInit() {
  }

  close(){
    this.dialogRef.close();
  }
}
