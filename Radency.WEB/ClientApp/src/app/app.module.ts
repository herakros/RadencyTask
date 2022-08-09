import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { BookListComponent } from './presentation/components/book-list/book-list.component';
import { BookListItemComponent } from './presentation/components/book-list-item/book-list-item.component';
import { BooksPageComponent } from './presentation/components/books-page/books-page.component';
import { EditBookComponent } from './presentation/components/edit-book/edit-book.component';
import { ViewBookComponent } from './presentation/components/view-book/view-book.component';

@NgModule({
  declarations: [
    AppComponent,
    BookListComponent,
    BookListItemComponent,
    BooksPageComponent,
    EditBookComponent,
    ViewBookComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    NgbModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
