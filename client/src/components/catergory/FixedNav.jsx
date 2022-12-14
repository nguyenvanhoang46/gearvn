import React from 'react'
import {BiCategory} from 'react-icons/bi';
const FixedNav = () => {
  return (
    <>
      <div className="flex w-[200px] bg-[#505050] text-[14px] text-[#fff] rounded py-[8px] px-[12px] items-center gap-2 ">
        <BiCategory className='text-[20px] ' />
        Danh mục sản phẩm
      </div>
    </>
  )
}

export default FixedNav
