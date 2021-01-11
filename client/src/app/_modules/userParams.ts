import { User } from "../_model/user";


export class UserParams {
    gender: string;
    minAge = 18;
    maxAge = 99;
    pageNumber = 1;
    pageSize = 5;
    //orderBy='lastActive';
    orderBy = 'lastActive';
    constructor(user: User) {
        this.gender = user.gender === 'female' ? 'male' : 'female';
    }
}