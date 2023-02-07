import React from 'react'
import { FiSearch } from 'react-icons/fi';
import { useContext } from 'react';
import { Cartcontext } from '../../contexts/cart/Context';
import { Link } from 'react-router-dom';
const InputSearch = () => {

  return (
    <div className='w-[50%] '>
      <form action="client/src/components/Header/InputSearch" className='flex relative border rounded-[20px] w-full pl-[15px] bg-[white] '>
            <input type="text" name="" id="" placeholder='Nhập mã hoặc tên sản phẩm' className=' outline-none text-sm w-full' />
            <button type="submit" className='w-[40px] bg-[#ff391e] rounded-r-[30px] px-[10px] py-[10px] '>
              <FiSearch className='text-[white] ' />
            </button>
      </form>
    </div>
  )
}

export default InputSearch
