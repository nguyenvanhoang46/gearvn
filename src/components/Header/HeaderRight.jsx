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
            <Link to='/login'>
              <Button label="Đăng ký" icon={ <FaPenSquare  style={StyleIcon}/> }/>  
            </Link>        
            <Link to=''>
              <Button label="Đăng nhập" icon={ <MdAccountCircle  style={StyleIcon}/> }/>           
            </Link>
            <Link to=''>
              <Button label="Khuyết mãi" icon={ <HiOutlineLogout  style={StyleIcon}/> } />           
            </Link>
            <Link to=''>
              <Button label="Giỏ hàng " icon={ <BsFillCartFill style={StyleIcon} />}/>           
            </Link>
        </div>
    </>
  )
}

export default HeaderRight