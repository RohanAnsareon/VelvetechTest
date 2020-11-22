import {NgModule} from '@angular/core';
import {Routes, RouterModule} from '@angular/router';
import {StudentComponent} from './components/student/student.component';
import {GroupComponent} from './components/group/group.component';

const routes: Routes = [
  {path: '', redirectTo: 'student', pathMatch: 'full'},
  {path: 'student', component: StudentComponent},
  {path: 'group', component: GroupComponent},
  {path: '**', redirectTo: 'student', pathMatch: 'full'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {
}
