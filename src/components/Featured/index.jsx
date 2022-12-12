import React from 'react'
import {MdNavigateNext} from 'react-icons/md';
import { IconContext } from "react-icons";



const TitleFeatured = ({label}) => {
  
  return (
   <div className="flex bg-[#d7202c] items-center justify-between">
     <h2 className='text-[22px] py-[10px] px-[20px] text-[#fff] font-medium'>
      {label}
    </h2>
    <a href="" className='flex items-center text-[#fff] font-medium text-[14px] hover:text-[#f45b4f] '>
        <span>Xem tất cả</span>
        <MdNavigateNext size={25} />
    </a>
   </div>
  )
}

export default TitleFeatured