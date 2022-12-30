import React from 'react'
import { useContext } from 'react';
import { Link, useNavigate } from 'react-router-dom'
import { HiOutlineLogout } from 'react-icons/hi';
import { BsFillCartFill, BsBoxArrowInLeft } from 'react-icons/bs';
import { MdAccountCircle } from 'react-icons/md';
import { FaPenSquare } from 'react-icons/fa';
import Button from '../Button';
import { AuthContext } from '../../contexts/AuthProvider';

const StyleIcon = {
  fontSize: "24px",
}
const HeaderRight = () => {
  const { auth } = useContext(AuthContext);
  let navigate = useNavigate();
  
  const logout = () => {
    localStorage.removeItem("token", true)
    localStorage.removeItem("refreshToken", true)
    navigate("/login");
    window.location.reload(false)
  }

  return (
    <>
      <div className="flex gap-4 ml-10 uppercase">
        {auth === null ?
          <>
            <Link to='/register'>
              <Button label="Đăng ký" icon={<FaPenSquare style={StyleIcon} />} />
            </Link>
            <Link to='/login'>
              <Button label="Đăng nhập" icon={<MdAccountCircle style={StyleIcon} />} />
            </Link>
          </>
          :
          <>
            <Link >
              <div className="flex gap-2 items-center text-[11px] mt-1 font-bold">{auth.fullName}</div>
            </Link>
            <button onClick={logout}>
              <Button label="Đăng Xuất" icon={<BsBoxArrowInLeft style={StyleIcon} />} />
            </button>
          </>
        }
        <Link className='flex gap-2' to='/navbar'>
          <img className='max-w-[24px] max-h-[25px] ' src="//theme.hstatic.net/1000026716/1000440777/14/ak4.png?v=30809" />
          <Button label="Khuyết mãi" />
        </Link>
        <Link to=''>
          <Button label="Giỏ hàng " icon={<BsFillCartFill style={StyleIcon} />} />
        </Link>
      </div>

    </>
  )
}

export default HeaderRight