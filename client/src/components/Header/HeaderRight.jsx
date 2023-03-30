import React from 'react'
import { useContext } from 'react';
import { Link, useNavigate } from 'react-router-dom'
import { BsFillCartFill, BsBoxArrowInLeft } from 'react-icons/bs';
import { MdAccountCircle } from 'react-icons/md';
import { BiUserCircle } from 'react-icons/bi';
import { FaPenSquare } from 'react-icons/fa';
import Button from '../Button';
import { AuthContext } from '../../contexts/AuthProvider';
import { Cartcontext } from '../../contexts/cart/Context';

const StyleIcon = {
  fontSize: "24px",
}
const HeaderRight = () => {
  const { auth, clearAuth } = useContext(AuthContext);
  console.log("auth", auth);
  let navigate = useNavigate();

  const Globalstate = useContext(Cartcontext);
  const state = Globalstate.state;

  const logout = () => {
    localStorage.removeItem("token", true)
    localStorage.removeItem("refreshToken", true)
    clearAuth()
    navigate("/login");
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
            <Link className='group'>
              <div className=" flex gap-2 items-center text-[11px] mt-1 font-bold">
                {auth.fullName}
              </div>
              <ul className='hidden w-[180px] shadow-md rounded absolute  group-hover:block z-50 bg-white p-3'>
                <div className=" flex gap-2 items-center text-[11px] mt-1 font-bold">
                  <BiUserCircle className='text-[26px]' />
                  {auth.fullName}
                </div>
                <li className='py-[7px]'>
                  <Link to='/profile' className='text-[12px] flex items-center gap-2'>
                    <BiUserCircle className='text-[16px]' />
                    Thông tin tài khoản
                  </Link>
                </li>
                <li className='py-[7px]'>
                  <Link to='/profile' className='text-[12px] flex items-center gap-2'>
                    <BiUserCircle className='text-[16px]' />
                    Quản lý đơn hàng
                  </Link>
                </li>
                <li className='py-[7px]'>
                  <Link to='/profile' className='text-[12px] flex items-center gap-2'>
                    <BiUserCircle className='text-[16px]' />
                    Quản lý đơn hàng
                  </Link>
                </li>
                <li className='py-[7px]'>
                  <Link to='/profile' className='text-[12px] flex items-center gap-2'>
                    <BiUserCircle className='text-[16px]' />
                    Quản lý đơn hàng
                  </Link>
                </li>
              </ul>
            </Link>
            <button onClick={logout}>
              <Button label="Đăng Xuất" icon={<BsBoxArrowInLeft style={StyleIcon} />} />
            </button>
          </>
        }
        <Link className='flex gap-2' to='/tableproduct'>
          <img className='max-w-[24px] max-h-[25px] ' src="//theme.hstatic.net/1000026716/1000440777/14/ak4.png?v=30809" />
          <Button label="Khuyết mãi" />
        </Link>
        <Link className='flex relative' to='/cart'>
          <Button label="Giỏ hàng " icon={<BsFillCartFill style={StyleIcon} />} />
          <p className='absolute top-[-7px] right-[57px] text-[11px] text-white bg-[#ea1c00] font-normal rounded-[50%] text-center leading-[14px] min-w-[20px] border-[3px] border-[#ea1c00] '>
            {state.length}
          </p>
        </Link>
      </div>

    </>
  )
}

export default HeaderRight