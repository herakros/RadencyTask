import { Component, Input, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Observable, ReplaySubject } from 'rxjs';
import { CreateOrUpdateBook } from 'src/app/core/models/createOrUpdateBook';
import { BooksService } from 'src/app/core/services/books.service';

@Component({
  selector: 'app-edit-book',
  templateUrl: './edit-book.component.html',
  styleUrls: ['./edit-book.component.css']
})
export class EditBookComponent implements OnInit {

  form: FormGroup;
  isEdit: boolean = false;
  @Input() bookId: number;
  error: string;
  base64Output: string;
  buttonText: string;

  constructor(private formBuilder: FormBuilder,
    private bookService: BooksService,
    private router: Router) { }

  ngOnInit() {
    if(this.bookId){
      this.isEdit = true;
      this.buttonText = 'Edit'
      this.bookService.getSingle(this.bookId).subscribe(data => {
        let book = <CreateOrUpdateBook>data;
        this.form = this.formBuilder.group({
          title: new FormControl(book.title, [Validators.required]),
          cover: new FormControl(book.cover, [Validators.required]),
          genre: new FormControl(book.genre, [Validators.required]),
          author: new FormControl(book.author, [Validators.required]),
          content: new FormControl(book.content, [Validators.required])
        });

      })
    } else {
      this.buttonText = 'Add'
      this.form = this.formBuilder.group({
        title: new FormControl('', [Validators.required]),
        cover: new FormControl('', [Validators.required]),
        genre: new FormControl('', [Validators.required]),
        author: new FormControl('', [Validators.required]),
        content: new FormControl('', [Validators.required])
      });
    }
  }

  save() {
    let book = <CreateOrUpdateBook>this.form.value;
    book.cover = this.base64Output;
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

  clearForm() {
    this.form.reset();
  }

  onFileSelected(event: any) {
    this.convertFile(event.target.files[0]).subscribe(base64 => {
      this.base64Output = base64;
    });
  }

  convertFile(file : File) : Observable<string> {
    const result = new ReplaySubject<string>(1);
    const reader = new FileReader();
    reader.readAsBinaryString(file);
    reader.onload = (event) => result.next(btoa(event.target.result.toString()));
    return result;
  }
}
