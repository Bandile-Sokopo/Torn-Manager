import { Photo } from "./Photo";

export interface Member {
  id: number;
  username: string;
  photourl: string;
  age: number;
  knownas: string;
  gender: string;
  photo: Photo;
}
