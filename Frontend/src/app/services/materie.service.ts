import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Materie } from '../interfaces/materie';
import { MaterieDto } from '../interfaces/materie-dto';

@Injectable({
  providedIn: 'root'
})
export class MaterieService {

  constructor(private http: HttpClient) { }

  readonly APIUrl = "https://localhost:7108/api/Materii";
  
  getMaterii(): Observable<Materie[]> {
    const url = `${this.APIUrl}`;
    return this.http.get<Materie[]>(url);
  }

  postMaterie(materieDto: MaterieDto): Observable<Materie> {
    const url = `${this.APIUrl}`;
    return this.http.post<Materie>(url, materieDto);
  }
}
