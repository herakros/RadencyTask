import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Book } from 'src/app/core/models/book';
import { BooksService } from 'src/app/core/services/books.service';

@Component({
  selector: 'app-edit-book',
  templateUrl: './edit-book.component.html',
  styleUrls: ['./edit-book.component.css']
})
export class EditBookComponent implements OnInit {

  form: FormGroup;
  isEdit: boolean = false;
  bookId: number;
  isErrorResponse: boolean = false;
  error: string;

  constructor(private formBuilder: FormBuilder,
    private activatedRoute: ActivatedRoute,
    private bookService: BooksService,
    private router: Router) { }

  ngOnInit() {
    this.form = this.formBuilder.group({
      title: new FormControl('', [Validators.required]),
      cover: new FormControl('', [Validators.required]),
      genre: new FormControl('', [Validators.required]),
      author: new FormControl('', [Validators.required]),
      content: new FormControl('', [Validators.required])
    });

    this.activatedRoute.paramMap.subscribe((p) => {
      if(p.has('id')){
        this.bookId = Number(p.get('id'));
        if (this.bookId) {
          this.isEdit = true;
          this.bookService.getSingle(this.bookId).subscribe((book: Book) => {
            this.form.get('title').patchValue(book.title);
            this.form.get('cover').patchValue(book.cover);
            this.form.get('genre').patchValue(book.genre);
            this.form.get('author').patchValue(book.author);
            this.form.get('content').patchValue(book.content);
          });
        }
      }
    });
  }

  save() {
    let book = <Book>this.form.value;
    if(this.isEdit) {
      book.id = this.bookId;
      this.bookService.add(book).subscribe(
        res => {
          this.router.navigate(['/']);
        },
        err => {
          console.log(err);
        }
      )
    } else {
      this.bookService.add(book).subscribe(
        res => {
          this.router.navigate(['/']);
        },
        err => {
          console.log(err);
        }
      )
    }
  }
}
