import { Entity } from "./entity";

export class MarketingInquiry extends Entity {
    InquiryDate:Date
    InquiryContactPerson:string
    Mobile:string
    Telephone:string
    Email:string
    FurtherContactType:string
    Remarks:string
    IsActive:boolean
}
