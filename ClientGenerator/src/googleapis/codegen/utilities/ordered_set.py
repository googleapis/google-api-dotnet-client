#!/usr/bin/python2.7
"""Ordered set implementations."""

import collections


class _OrderedSetBase(object):

  def __init__(self, iterable=None):
    self._set = collections.OrderedDict()
    if iterable:
      for i in iterable:
        self._set[i] = 1

  def __len__(self):
    return len(self._set)

  def __contains__(self, thing):
    return thing in self._set

  def __iter__(self):
    return iter(self._set)


class _MutableSetBase(_OrderedSetBase):
  def add(self, thing):  # pylint:disable=g-bad-name
    self._set[thing] = 1

  def discard(self, thing):  # pylint:disable=g-bad-name
    if thing in self._set:
      del self._set[thing]

  def clear(self):  # pylint:disable=g-bad-name
    self._set.clear()


class FrozenOrderedSet(_OrderedSetBase, collections.Set, collections.Hashable):
  __hash__ = collections.Set._hash


class MutableOrderedSet(_MutableSetBase, collections.MutableSet):
  pass
