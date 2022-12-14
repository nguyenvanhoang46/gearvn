import React from 'react'
import {Link} from 'react-router-dom'
import { HiOutlineLogout } from 'react-icons/hi';
import { BsFillCartFill } from 'react-icons/bs';
import { MdAccountCircle } from 'react-icons/md';
import { FaPenSquare } from 'react-icons/fa';

import Button from '../Button';
const StyleIcon = {
  fontSize: "24px",
}
const HeaderRight = () => {
  return (
    <>
        <div className="flex gap-4 ml-10 uppercase">
            <Link to='/register'>
              <Button label="Đăng ký" icon={ <FaPenSquare  style={StyleIcon}/> }/>  
            </Link>        
            <Link to='/login'>
              <Button label="Đăng nhập" icon={ <MdAccountCircle  style={StyleIcon}/> }/>           
            </Link>
            <Link className='flex gap-2' to=''>
              <img className='max-w-[24px] max-h-[25px] ' src="//theme.hstatic.net/1000026716/1000440777/14/ak4.png?v=30809" />
              <Button label="Khuyết mãi" />           
            </Link>
            <Link to=''>
              <Button label="Giỏ hàng " icon={ <BsFillCartFill style={StyleIcon} />}/>           
            </Link>
        </div>
    </>
  )
}

export default HeaderRight