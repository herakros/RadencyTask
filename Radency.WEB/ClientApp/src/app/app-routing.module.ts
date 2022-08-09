import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { BookListItemComponent } from './presentation/components/book-list-item/book-list-item.component';
import { BookListComponent } from './presentation/components/book-list/book-list.component';
import { BooksPageComponent } from './presentation/components/books-page/books-page.component';
import { EditBookComponent } from './presentation/components/edit-book/edit-book.component';
import { ViewBookComponent } from './presentation/components/view-book/view-book.component';

const routes: Routes = [
  { path: '', component: BooksPageComponent },
  { path: 'book/list', component:BookListComponent },
  { path: 'book/list/:id', component:BookListItemComponent },
  { path: 'book/edit/:id', component:EditBookComponent },
  { path: 'book/view/:id', component:ViewBookComponent },
  { path: '**', component: BooksPageComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
