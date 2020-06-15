import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-upload-file',
  templateUrl: './upload-file.component.html',
  styleUrls: ['./upload-file.component.css']
})
export class UploadFileComponent implements OnInit {

  file;

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
  }

  onChange(event) {
    console.log(event);
    const selectedFile = <FileList>event.srcElement.files;
    document.getElementById('forFileLabel').innerHTML = selectedFile[0].name;
    this.file = selectedFile;
  }

  onUpload() {
    const formData = new FormData();
    formData.append('file', this.file);

    this.http.post('http://localhost:5000/api/Users/import-file', formData)
      .subscribe(resposta => console.log("Upload Ok!"));
  }
}
